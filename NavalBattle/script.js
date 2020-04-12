var location1 = 3;
var location2 = 4;
var location3 = 5;
var quess;/*попытки*/
var hits = 0;/*попадания*/
var quesses = 0;/*кол-во попыток*/
var isSunk = false; /*корабль потоплен или нет*/

while (isSunk == false) {
    quess = prompt("Ready, aim, fire! (enter a number 0-6) :");
    if (quess < 0 || quess > 6) {
        alert("Please enter a valid cell number!");
    } else {
        quesses = quesses + 1;

        if (quess == location1 || quess == location2 || quess == location3) {
            alert("HIT!");
            hits = hits + 1;
            if (hits == 3) {
                isSunk = true;
                alert("You sank my battleship!");
            }
        }
        else {
            alert("MISS");
        }
    }    
}

var stats = "You took " + quesses + " quesses to sink the battleship, " +
    "which means your shooting accuracy was " + (3 / quesses);
alert(stats);