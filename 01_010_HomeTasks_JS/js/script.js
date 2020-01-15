window.onload = function () {

    this.document.querySelector('#menu').onmouseover = menuShow;
    this.document.querySelector('#menu').onmouseout = menuHide;

    this.document.onkeydown = function (event) {
        //console.log(event);
        if (event.code =='KeyM') menuShow();
        if (event.code =='Escape') menuHide();
    }

    function menuShow() {
        document.querySelector('#menu').style.left = 0;
    }
    function menuHide() {
        document.querySelector('#menu').style.left = '-230px';
    }
}


//document.getElementById('menu').onmouseover = function (event) {
//    var target = event.target;
//    if (target.className == 'menu-item') {
//        var s = target.getElementsByClassName('submenu');
//        closeMenu();
//        s[0].style.display ='block';
//    }
//}

//document.onmouseover = function (event) {
//    var target = event.target;
//    console.log(event.target);
//    if (target.className != 'menu-item' && target.className != 'submenu'){
//        closeMenu();
//    }
//}


//function closeMenu() {
//    var menu = document.getElementById('menu');
//    var subm = document.getElementsByClassName('submenu');
//    for (var i = 0; i < subm.length; i++) {
//        subm[i].style.display = "none";
//    }
//}

//var el = document.getElementsByClassName('menu-item');
//for (var i = 0; i < el.length; i++) {
//    el[i].addEventListener('onDblClick', showSub, false);
//    el[i].addEventListener('mouseleave', hideSub, false);
//}

//function showSub() {
//    if (this.children.length > 1) {
//        this.children[1].style.height = "auto";
//        this.children[1].style.opacity = "1";
//        this.children[1].style.overflow = "visible";
//    }
//    else {
//        return false;
//    }
//}

//function hideSub() {
//    if (this.children.length > 1) {
//        this.children[1].style.height = "0";
//        this.children[1].style.opacity = "0";
//        this.children[1].style.overflow= "hidden";
//    } else {
//        return false;
//    }
//}