alert("Hello");
document.write("UUUUUUUUUUUUUUUUUUUUUUUUU");

class Decorator {
    constructor(id, category, name, price, kkal) {
        this.id = id;
        this.category = category;
        this.name = name;
        this.price = price;
        this.kkal = kkal;
    }
}

class Hamburger {
    constructor(hamburgerSize = null, insideDecorator = null) {
        this.hamburgerSize = hamburgerSize;
        this.insideDecorator = insideDecorator;
        this.toppingDecorator = new Set();
    }
}

function Hamburger(size, decorator) {
    this.size = size;
    this.decorator = decorator;

    this.print = function () {
        document.write(this.size + " " + this.decorator);
    }
}

Hamburger.size_small = 10;
Hamburger.size_large = 20;
Hamburger.decorator_cheese = 15;
Hamburger.decorator_salad = 16;
Hamburger.decorator_potato = 12;   
Hamburger.topping_mayo = 5;
Hamburger.topping_spice = 6;

Hamburger.prototype.addTopping = function (topping) { };
Hamburger.prototype.removeTopping = function (topping) { };

Hamburger.prototype.getTopping = function () { };
//Hamburger.prototype.setSize = function () {
//    return this.
//};
Hamburger.prototype.getDecorator = function () { };

Hamburger.prototype.culculatePrice = function () {
    return "Price : " + this.size_small + this.decorator_cheese;
};
Hamburger.prototype.calculateCalories = function () { };

function HamburgerExceptiop() { };

var h1 = new Hamburger(size_small, decorator_cheese);
h1.print();

document.write(Hamburger.size_small);
document.write(h1.culculatePrice);

document.write("jjjjjjjjjjjjjjjjjjjjjjj");