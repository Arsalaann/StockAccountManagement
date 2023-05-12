namespace StockAccountManagement{
    class AllStock{
        public List<Stock> MyStock=new List<Stock>();

        public void AddStock(Stock stock){
            MyStock.Add(stock);
        }
        public void DisplayStocks(){
            foreach(var stock in MyStock)
                Console.WriteLine(stock.stockName+"  "+stock.shareCount+"  "+stock.price+" "+stock.stockValue);
        }
    }
}