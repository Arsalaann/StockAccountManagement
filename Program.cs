namespace StockAccountManagement{
    class Program{
        public static void Main(string [] args){
            AllStock allStock=new AllStock();
            Console.Write("Enter number of stacks: ");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++){
                Console.Write("Name: ");
                string stockName=Console.ReadLine();

                Console.Write("Count: ");
                int stockCount=Convert.ToInt32(Console.ReadLine());

                Console.Write("Price: ");
                double price=Convert.ToDouble(Console.ReadLine());

                Stock dummy=new Stock(stockName, stockCount, price);

                dummy.stockValue=price*stockCount;

                allStock.AddStock(dummy);
            }

            allStock.DisplayStocks();
        }
    }
}