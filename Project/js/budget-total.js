function getRes() {
    'use strict';
    total = document.getElementById('total');
    total.value = 0;
    var f = document.getElementById('form1');
    inputs = f.getElementsByTagName('input');
    var res = 0;

    for (i = 0; i < inputs.length; i++)
    {
        if (!isNaN(inputs[i].value*1))
        res += inputs[i].value*1;
    }
    total.value = res;
}