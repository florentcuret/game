namespace Game
{
    public class Player
    {
        private readonly string nickName;
        private string firstName = default!;
        private string lastName = default!;
        private readonly List<Address> addresses = new();

        public string GetNickName() {
            return this.nickName;
        }

        public void SetFirstName(string firstname) {
            this.firstName = firstname;
        }
        public string GetFirstName() {
            return this.firstName;
        }

        public void SetLastName(string lastName) {
            this.lastName = lastName;
        }
        public string GetLastName() {
            return this.lastName;
        }

        public void AddAddress(Address address) {
            this.addresses.Add(address);
        }
        public Address GetAddressByIndex(int index) {
            return addresses[index];
        }

        public Player(string nickName) {
            this.nickName = nickName;
        }
    }
}