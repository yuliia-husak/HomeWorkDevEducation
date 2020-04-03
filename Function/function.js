var arr = Array(10);
document.write(arr.length);
for (var i = 0; i < arr.length; i++) {
    arr[i] = i;
    document.write(arr[i]);
}

function sequence(start = 0, step = 1) {
    start -= step;
    return function () {
        return start += step;
    }
}

document.write("<br />");
document.write(' ');
var generator = sequence(10, 3);
document.write(generator);

document.write("<br/>");
function take(fn, count) {
    var array = [];
    for (i = 0; i < count; i++) {
        array[i] = fn();
    }
    return array;   
}

var gen2 = sequence(0, 2);
document.write(take(gen2, 5));

document.write("<br /> Fanction map: <br />");
function map(fn, array) {
    var narr = [];
    for (var i = 0; i < array.length; ++i) {
        narr.push(square(array[i]));
    }
    return narr;
}
function square(x) { return x * x; }
var arr = [1, 2, 3, 4, 5, 6];
document.write(arr + "<br />");
document.write(map(square, arr) + "<br />");

//----------------------------------------------
var fmap = function (a, gen) {
    return function () {
        var argsCount = arguments.length;
        var newArray = [];
        for (i = 0; i < argsCount; i++) {
            newArray[i] = arguments[i];
        }
        x = a(gen.apply(null, newArray));
        return x;
    }
}

document.write("Fanction fmap : <br />");
var gen3 = sequence(1, 1);
var squareGen = fmap(square, gen3);

document.writeln(squareGen());
document.writeln(squareGen());
document.writeln(squareGen());
document.writeln(squareGen());

document.write("<br /> Fanction filter: <br />");

function filter(arr, isEven) {
    var newArray = [];
    for (i = 0; i < arr.length; i++) {
        if (isEven(arr[i]))
            newArray.push(arr[i]);
    }
    return newArray;
}
var input = [1, 2, 3, 4, 5, 6];
function isEven(x) { return x % 2 == 0; }
document.write(filter(input,isEven));
