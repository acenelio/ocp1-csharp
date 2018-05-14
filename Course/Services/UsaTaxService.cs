namespace Course.Services {
    class UsaTaxService : ITaxService {

        public double Tax(double amount) {
            return amount * 0.12;
        }
    }
}
