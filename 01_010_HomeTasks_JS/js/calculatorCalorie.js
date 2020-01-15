//Формула по Миффлину – Сан Жеору:
//Женская формула: 10 х вес + 6, 25 х рост – 5 х возраст – 161;
//Мужская формула: 10 х вес + 6, 25 х рост – 5 х года + 5.

//Формула по Харрису - Бенедикту:
//Женская формула: 655, 1 + 9, 563 х вес + 1, 85 х рост — 4, 676 х возраст;
//Мужская формула: 66, 5 + 13, 75 х вес + 5, 003 х рост – 6, 775 х возраст

//Важно: увидеть точную индивидуальную суточную норму можно, если умножить
//окончательный результат на показатель физической нагрузки.
//Эта величина составляет 1,2 при самом минимальном уровне активности,
//    1, 9 – при максимальном, характерном для спортсменов.
//При средней нагрузке она равна примерно 1, 4.

//чтоб не обновлялась страница!!!!
document.getElementById('forma').onsubmit = function () { return false };

function raschitat() {
    age = document.getElementById('age').value;
    weight = document.getElementById('weight').value;
    height = document.getElementById('height').value;
    kt = 1;

    //точная суточная норма
    activity = document.getElementById('activity').value;
    switch (activity) {
        case "oneTwo":
        case "never":
            kt = 1.2;
            break;
        case "threeFour":
            kt = 1.4;
            break;
        case "fiveSix":
        case "everyDay":
            kt = 1.9;
            break;
        case "oneTwo":
            kt = 1.2;
            break;
        default:
            kt = 1;
            break;
    }


    resultFemMif = (10 * parseInt(weight) + 6.25 * parseInt(height) - 5 * parseInt(age) - 161) * kt;
    resultManMif = 10 * parseInt(weight) + 6.25 * parseInt(height) - 5 * parseInt(age) + 5;

    resultFemHar = 655.1 + 9.562 * parseInt(weight) + 1.85 * parseInt(height) - 4.676 * parseInt(age);
    resultManHar = 66.5 + 13.75 * parseInt(weight) + 5.003 * parseInt(height) - 6.775 * parseInt(age);
        
    document.getElementById('resultKalorie').innerHTML = " Ваша точная индивидуальная суточная норма составляет " +
        resultFemMif + " ккал ";

}