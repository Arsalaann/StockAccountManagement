namespace StockAccountManagement{
    class Program{
        public static void Main(string [] args){
            Stock stock1=new Stock("Rice",3,23.44);
            Stock stock2=new Stock("Mice",4,3.44);
            Stock stock3=new Stock("Cice",5,2.44);

            AllStock allStock=new AllStock();
            allStock.AddStock(stock1);
            allStock.AddStock(stock2);
            allStock.AddStock(stock3);

            allStock.DisplayStocks();
        }
    }
}