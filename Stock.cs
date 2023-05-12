namespace StockAccountManagement{
    class Stock{
        public string stockName="";
        public double price,shareCount,stockValue;
        public Stock(string a,int b,double c){
            stockName=a;
            shareCount=b;
            price=c;
        }
    }
}