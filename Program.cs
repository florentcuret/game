namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // prepare data
            // create player1 with nickName RobTheBob
            Player player1 = new ("RobTheBob");
            // create addressHH
            Address addressHH = new ("abc str.", "123", "20000", "Hamburg", "Germany");
            // create addressHH
            Address addressKO = new ("def str.", "456", "56070", "Koblenz", "Germany");
            // add addressHH to player1 (in addresses)
            player1.AddAddress(addressHH);
            // add addressHH to player1 (in addresses)
            player1.AddAddress(addressKO);

            // output data
            // output nickName of player1
            Console.WriteLine(player1.GetNickName());
            // outut ConcatAddress of the first address in the list addresses of player1 
            Console.WriteLine(player1.GetAddressByIndex(0).ConcatAddress());
            // outut ConcatAddress of the second address in the list addresses of player1 
            Console.WriteLine(player1.GetAddressByIndex(1).ConcatAddress());

            // prepare data
            Club club1 = new("The Schoking Bar");
            club1.AddAddress(addressKO);

            // output data
            Console.WriteLine(club1.GetName());
            Console.WriteLine(club1.GetAddressByIndex(0).ConcatAddress());

            // prepare data
            addressKO.SetStreet("ghi str.");

            //output data
            Console.WriteLine(player1.GetNickName());
            Console.WriteLine(player1.GetAddressByIndex(0).ConcatAddress());
            Console.WriteLine(player1.GetAddressByIndex(1).ConcatAddress());
            Console.WriteLine(club1.GetName());
            Console.WriteLine(club1.GetAddressByIndex(0).ConcatAddress());
        }
    }
}