namespace StockAccountManagement{
    class Stock{
        public string stockName="";
        public int shareCount;
        public double price;
        public Stock(string a,int b,double c){
            stockName=a;
            shareCount=b;
            price=c;
        }
    }
}