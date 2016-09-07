function FactoryCustomer() {
    var _create = function (type) {
        if (type == "Customer") {
            
            return new Customer();
        }
        else {
            return new CustomerGold();
        }
    }
    return {
        Create: _create
    };
}