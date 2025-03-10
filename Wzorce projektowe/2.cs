namespace ConsoleApp12
{
	//------------------------------EmailMessage
	public class EmailMessage
	{
		public string From { get; private set; }
		public string To { get; private set; }
		public string Subject { get; private set; }
		public string Content { get; private set; }
		public List<string> CC { get; private set; }
		public string BCC { get; private set; }

		private EmailMessage() { }

		public static IFromRequired Builder() => new EmailMessageBuilder();
		// dokończ klasę budowniczego, aby 
		// From
		// To
		// Content
		// były obowiązkowymi parametrami
		public interface IFromRequired
		{
			IToRequired From(string from);
		}

		public interface IToRequired
		{
			EmailMessageBuilder To(string to);
		}

		public interface IContentRequired
		{
			EmailMessageBuilder Content(string content);
		}

		public class EmailMessageBuilder : IFromRequired, IToRequired, IContentRequired
		{
			private string _from;
			private string _to;
			private string _subject;
			private string _content;
			private string _body;
			private List<string> _cc;
			private string _bcc;
			public EmailMessageBuilder()
			{
				_cc = new List<string>();
			}

			public IToRequired From(string from)
			{
				_from = from;
				return this;
			}

			public IContentRequired To(string to)
			{
				_to = to;
				return this;
			}



			public EmailMessageBuilder Subject(string subject)
			{
				_subject = subject;
				return this;
			}
			public EmailMessageBuilder CC(string cc)
			{
				if (!string.IsNullOrWhiteSpace(cc))
				{
					_cc.Add(cc);
				}
				return this;
			}

			public EmailMessageBuilder Content(string content)
			{
				_content = content;
				return this;
			}

			public EmailMessage Build()
			{
				if (string.IsNullOrWhiteSpace(_from))
					throw new ArgumentException("Pole nie moze byc puste");
				if (string.IsNullOrWhiteSpace(_to))
					throw new ArgumentException("Pole nie moze byc puste");
				if (string.IsNullOrWhiteSpace(_content))
					throw new ArgumentException("Pole nie moze byc puste");
				return new EmailMessage()
				{
					From = _from,
					To = _to,
					Subject = _subject,
					Content = _content,
					CC = _cc,
					BCC = _bcc,
				};
			}

			EmailMessageBuilder IToRequired.To(string to)
			{
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return
				$"{nameof(From)}: {From}, {nameof(To)}: {To}, {nameof(Subject)}: {Subject}, {nameof(Content)}: {Content}, {nameof(CC)}: {CC}, {nameof(BCC)}: {BCC}";
		}

	}

	//---------------------PasswordChecker

	public class PasswordChecker
	{
		private PasswordOptions _options;

		public PasswordChecker(PasswordOptions options)
		{
			_options = options;
		}

		public bool CheckPassword(string password, out string errorMessage)
		{
			if (password.Length < _options.Min)
			{
				errorMessage = "Password must be at least " + _options.Min + " characters long.";
				return false;
			}

			if (password.Length > _options.Max)
			{
				errorMessage = "Password must be shorter than " + _options.Max + ".";
				return false;
			}

			if (!password.Any(char.IsDigit))
			{
				errorMessage = "Password must contain one digit";
				return false;
			}
			if (_options.HasUpper && !password.Any(char.IsUpper))
			{
				errorMessage = "Password must contain at least one uppercase letter.";
				return false;
			}

			if (_options.HasSpecial && !password.Any(ch => !char.IsLetterOrDigit(ch)))
			{
				errorMessage = "Password must contain at least one special character.";
				return false;
			}

			errorMessage = string.Empty;
			return true;
		}

	}


	//---------------------PasswordOptions

	public class PasswordOptions
	{
		public int Min { get; set; } = 3;
		public int Max { get; set; } = 20;
		public bool HasDigit { get; set; } = false;
		public bool HasUpper { get; set; } = false;
		public bool HasSpecial { get; set; } = false;

	}
	//---------------------Prototype>Book

	public class Book : ICloneable
	{
		public string Title { get; set; }
		public int LibraryId { get; set; }
		public string Author { get; set; }


		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public override string ToString()
		{
			return
				$"{nameof(Title)}: {Title}, {nameof(LibraryId)}: {LibraryId}, {nameof(Author)}: {Author}";
		}
	}

	//---------------------PROGRAM


	class Program
	{
		static void Main(string[] args)
		{
			/*            var message = EmailMessage.Builder()//IFromRequired
                            .From("ewa@op.pl") //IToRequired
                            .To("adam@wse.edu.pl")
                            .Content("Spotkamy się o 8:00?")
                            .Subject("Spotkanie")//EmailMessageBuilder
                            .Build();

                        Console.WriteLine(message);*/

			//CheckerDemo();

			Book book = new Book()
			{
				Title = "Wzorce Gr1",
				Author = "CS",
				LibraryId = 1
			};

			Book copy = (Book)book.Clone();
			copy.LibraryId = 2;
			Console.WriteLine(book);
			Console.WriteLine(copy);

		}

		private static void CheckerDemo()
		{
			var checker = new PasswordChecker(new PasswordOptions()
			{
				Min = 6,
				HasDigit = true,

			});

			Console.WriteLine(checker.CheckPassword("123456", out string error));
			Console.WriteLine(error);
		}
	}
}
