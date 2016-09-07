
function Customer() {
    this.CustomerCode = "";
    this.CustomerName = "";
    this.Validate = function () {
        debugger;
        if (this.CustomerCode.length == 0) {
            alert("code Not Proper");
        }
    }

}

function CustomerGold() {
    debugger;
    this.Validate = function () {
        if (this.CustomerCode.length != 0) {
            alert("Code not proper");
        }
        if (this.CustomerName.length == 0) {
            alert("Name not proper");
        }
    }
}

CustomerGold.prototype = new Customer();