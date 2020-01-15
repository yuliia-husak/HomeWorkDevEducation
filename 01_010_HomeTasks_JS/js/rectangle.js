var a = prompt("Enter width rectangle: ", "here");
var b = prompt("Enter height rectangle: ", "here");
for (var i = 0; i < b; i++) {
    for (var j = 0; j < a; j++) {
        document.write("*");
    }
    document.write("<br>");
}