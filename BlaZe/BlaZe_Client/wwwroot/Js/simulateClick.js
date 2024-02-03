function focus(elem) {
    document.getElementById(elem).focus();
}

function eventFire(el, etype) {
    console.log(el);
    if (el.fireEvent) {
        el.fireEvent('on' + etype);
    } else {
        var evObj = document.createEvent('Events');
        evObj.initEvent(etype, true, false);
        el.dispatchEvent(evObj);
    }
}

function ClickMe(elem) {
    eventFire(document.getElementById(elem), 'click');
}

function ResetCarousel(elem) {
    $('.carousel').carousel({
        pause: true,
        interval: false
    }).carousel(0);
}
