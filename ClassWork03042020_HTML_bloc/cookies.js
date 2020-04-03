window.onload = function () {

    function $(id) {
        return document.getElementById(id);
    }

    var f = this.document.forms[0];

    document.getElementById("Setbutton").onclick = function () {
        var res = "";
        res += f.cookieName.value + "=" + f.cookieValue.value + ";";
        document.cookie = res;      
        

    }

    document.getElementById("button").onclick = function () {
        alert(document.cookie);
    }


   

}


function init() {
    var output = document.getElementById("output");
    var btn1 = document.getElementById("btn1");
    var btn2 = document.getElementById("btn2");

    btn1.onclick = function () {
        window.localStorage.setItem("key1", document.cookie);      
    }

    btn2.onclick = function () {
        
        output.innerHTML += window.localStorage.getItem("key1");
       
    }
}

window.addEventListener("load", init, false);

    
    
