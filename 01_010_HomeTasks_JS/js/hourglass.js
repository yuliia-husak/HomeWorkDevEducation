var k = prompt("Enter height time: ", "here");
    var i, j;
    for (i = k; i > 0; i--) {
        for (j = k; i < j; j--) {
            document.write();
        }
        for (j = 0; i > j; j++) {
            document.write('*');
        }
        for (j = 0; i > j; j++) {
            document.write('*');
        }
        document.write("<br/>");
    }

    for (i = 0; i <= k; i++) {
        for (j = 0; j < (k - (i + 1)); j++) {
            document.write();
        }
        for (j = 0; j <= (2 * i) + 1; j++) {
            document.write('*');
        }
        document.write("<br/>");
    }

