namespace Game
{
	public class Club
	{
		private string name;
		private readonly List<Address> addresses = new();

		public string GetName(){
			return this.name;
		}

		public void AddAddress(Address address) {
			this.addresses.Add(address);
		}
		public Address GetAddressByIndex(int index) {
			return addresses[index];
		}

		public Club(string name) { 
			this.name = name;
		}
	}
}

