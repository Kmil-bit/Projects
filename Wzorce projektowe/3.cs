namespace ConsoleApp13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//DemoComposite();
			//AdapterDemo();
			//Zad1();  |       ZADANIE 1                 |
			//Zad2();   |       ZADANIE 2                 |
		}
		public static void AdapterDemo()
		{
			ClassicPowerSupply supply = new ClassicPowerSupply();
			ModernPowerSupply modernPower = new ModernPowerSupply(230);
			Adapter adapter = new Adapter() { Supply = modernPower };

			ComputerSystem computer = new ComputerSystem() { PowerSupply = adapter };
			computer.Restart();
		}
		public class Adapter : ClassicPowerSupply
		{
			public ModernPowerSupply Supply { get; init; }

			public override string PowerOff()
			{
				if (Supply.Voltage > 0)
				{
					Supply.TogglePower();
				}
				return $"set output to {Supply.Voltage}";
			}

			public override string PowerOn()
			{
				if (Supply.Voltage == 0)
				{
					Supply.TogglePower();
				}
				return $"set output to {Supply.Voltage}";
			}
		}
		public class ClassicPowerSupply
		{
			public virtual string PowerOn()
			{
				return "Set output to 230 V";
			}
			public virtual string PowerOff()
			{
				return "Set output to 0 V";
			}
		}
		public class ComputerSystem
		{
			public ClassicPowerSupply PowerSupply { get; init; }

			public void Restart()
			{
				Console.WriteLine("System shutting down...");
				string comm = PowerSupply.PowerOff();
				Console.WriteLine(comm);
				Thread.Sleep(1000);
				comm = PowerSupply.PowerOn();
				Console.WriteLine(comm);
				Console.WriteLine("System powered...");
			}
		}
		public class ModernPowerSupply
		{
			private double _voltage;

			public ModernPowerSupply(double voltage)
			{
				_voltage = voltage;
			}
			public double Voltage => isPowered ? _voltage : 0;

			private bool isPowered = false;

			public void TogglePower()
			{
				Console.WriteLine("Modern supply toggle output voltage!");
				isPowered = !isPowered;
			}
		}
		public static void DemoComposite()
		{
			EthernetCard card = new EthernetCard() { MacAddress = "23251232123" };
			Disk SSD = new Disk() { Capacity = 10 };
			CompositeDevice computer = new CompositeDevice();
			computer.AddDevice(card);
			computer.AddDevice(SSD);
			//Console.WriteLine(computer.Power);
			computer.PowerOn();
			//Console.WriteLine(computer.Power);
			//utwórz cloud z dwoma komputerami , jeden z dyskiem 20 G drugi z dyskiem 10
			CompositeDevice Cloud = new CompositeDevice();
			CompositeDevice computer2 = new CompositeDevice();
			Disk SSD2 = new Disk() { Capacity = 20 };
			Cloud.AddDevice(computer);
			Cloud.AddDevice(computer2);
			computer2.AddDevice(SSD2);
			computer2.PowerOn();
			Cloud.PowerOn();
			Console.WriteLine(Cloud.Power);
		}
		public static void Zad1()
		{
			Motherboard motherboard = new Motherboard()
			{
				CPU = new CPU(),
				RAM = new RAM() { capacity = 12 },
				klawiatura = new Keyboard(),
				mysz = new Mouse(),
				PCI_Slots = new List<PCI>
			{
				new PCI("Graphics Card"),
				new PCI("Sound Card"),
				new PCI("Network Card")
			}
			};
			motherboard.PowerOn();
			Console.WriteLine(motherboard.Power);
		}
		public static void Zad2()
		{
			IOldTvSet OTvSet = new OldTvSet();
			AnalogRemoteController OController = new AnalogRemoteController(OTvSet);
			OController.SetVolume(7);
			ModerTvSet modernTvSet = new ModerTvSet();
			IOldTvSet Adapter = new ModernTvAdapter(modernTvSet);
			AnalogRemoteController modernController = new AnalogRemoteController(Adapter);
			modernController.SetVolume(7);
		}
	}
	public abstract class Device
	{
		public abstract double Power { get; }
		private bool _powered = false;

		public virtual bool PowerOn()
		{
			return _powered = true;
		}
		public virtual bool PowerOff()
		{
			return _powered = false;
		}
		public bool IsPowered => _powered;
	}
	//Zdefiniuj klasę SSD - dysk o podanej pojemnosci, moc zalezy od wielokrotnosci GB , GB(5)
	public class Disk : Device
	{
		public double Capacity { get; init; }
		public override double Power => IsPowered ? 5 * Capacity : 0;
	}
	public class EthernetCard : Device
	{
		public String MacAddress { get; init; }
		public override double Power => IsPowered ? 5 : 0;
	}
	public class CompositeDevice : Device
	{
		private List<Device> _devices = new List<Device>();
		public override double Power => _devices.Select(d => d.Power).Sum();

		public void AddDevice(Device device)
		{
			_devices.Add(device);
		}
		public bool PowerOn()
		{
			return _devices.Select(d => d.PowerOn()).All(d => d);
		}
		public bool PowerOff()
		{
			return _devices.Select(d => d.PowerOff()).All(d => !d);
		}
	}
	//Zad1
	public class Motherboard : Device
	{
		public override bool PowerOn()
		{
			Console.WriteLine("Mainboard powered on.");
			CPU.PowerOn();
			_devices.Add(CPU);
			RAM.PowerOn();
			_devices.Add(RAM);
			klawiatura.PowerOn();
			_devices.Add(klawiatura);
			mysz.PowerOn();
			_devices.Add(mysz);

			foreach (var pciDevice in PCI_Slots)
			{
				pciDevice.PowerOn();
				_devices.Add(pciDevice);
			}
			return _devices.Select(d => d.PowerOn()).All(d => d);
		}
		private List<Device> _devices = new List<Device>();
		public override double Power => _devices.Select(d => d.Power).Sum();
		public List<PCI> PCI_Slots { get; set; } = new List<PCI>(3);
		public CPU CPU { get; set; }
		public RAM RAM { get; set; }
		public Keyboard klawiatura { get; set; }
		public Mouse mysz { get; set; }
	}

	public class Keyboard : Device
	{
		public override double Power => IsPowered ? 5 : 0;
	}
	public class CPU : Device
	{
		public override double Power => IsPowered ? 45 : 0;
	}
	public class RAM : Device
	{
		public double capacity { get; init; }
		public override double Power => IsPowered ? 0.25 * capacity : 0;
	}
	public class Mouse : Device
	{
		public override double Power => IsPowered ? 2 : 0;
	}
	public class PCI : Device
	{
		public string Nazwa { get; set; }
		public override double Power => IsPowered ? 15 : 0;
		public PCI(string nazwa)
		{
			Nazwa = nazwa;
		}
	}
	//zadanie 2 
	public interface IOldTvSet
	{
		public virtual void SetVolume(uint volume)
		{
			Console.WriteLine($"Old Tv Set: Volume set to {volume}");
		}
	}
	public class OldTvSet : IOldTvSet
	{
		public void SetVolume(uint volume)
		{
			Console.WriteLine($"Old Tv Set: Volume set to {volume}");
		}
	}
	public class ModerTvSet
	{
		public uint Volume { get; private set; } = 0;
		public void VolumeDown()
		{
			Volume--;
			Console.WriteLine($"Modern Tv Set: Volume -- {Volume}");
		}
		public void VolumeUp()
		{
			Volume++;
			Console.WriteLine($"Modern Tv Set: Volume ++ {Volume}");
		}
	}
	public class AnalogRemoteController(IOldTvSet oldTvSet)
	{
		public void SetVolume(uint volume)
		{
			oldTvSet.SetVolume(volume);

		}
	}
	public class ModernTvAdapter : IOldTvSet
	{
		private readonly ModerTvSet _modernTv;

		public ModernTvAdapter(ModerTvSet modernTv)
		{
			_modernTv = modernTv;
		}
		public void SetVolume(uint volume)
		{
			while (_modernTv.Volume > volume)
			{
				_modernTv.VolumeDown();
			}
			while (_modernTv.Volume < volume)
			{
				_modernTv.VolumeUp();
			}
		}
	}
}