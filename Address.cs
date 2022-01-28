namespace Game
{
	public class Address
	{

        private string street;
		private string streetNumber;
		private string postalCode;
		private string city;
		private string country;

		public void SetStreet(string street) { this.street = street; }
		public string GetStreet() { return this.street; }

		public void SetStreetNumber(string streetNumber) { this.streetNumber = streetNumber; }
		public string GetStreetNumber() { return this.streetNumber; }

		// there are postal codes with letters on earth, the question is do we frontend validation/bakcendvalidation/database validation or use an ext "Address" library just for my little project?
		public void SetPostalCode(string postalCode) { this.postalCode = postalCode; }
		public string GetPostalCode() { return this.postalCode; }

		public void SetCity(string city) { this.city = city; }
		public string GetCity() { return this.city; }

		public void SetCountry(string country) { this.country = country; }
		public string GetCountry() { return this.country; }

		public string ConcatAddress(){
			string fullAddress;
			fullAddress = this.street + " " + this.streetNumber + ", " + this.postalCode + " " + this.city  + ", " + this.country;
			return fullAddress;
        }

		public Address(string street, string streetNumber, string postalCode, string city, string country) {
			this.street = street;
			this.streetNumber = streetNumber;
			this.postalCode = postalCode;
			this.city = city;
			this.country = country;
		}

    }
}