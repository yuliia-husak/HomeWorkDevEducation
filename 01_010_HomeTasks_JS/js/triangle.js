var h = prompt("Enter height triangle: ", "here");
    var i, j;
    var l = h * 2 - 1;
    for (i = 0; i < l; i += 2) {
        for (j = 0; j < (l - i) / 2; j++)
            document.write();
        for (j = 0; j < i; j++)
            document.write('*');
        document.write("<br/>");
    }
