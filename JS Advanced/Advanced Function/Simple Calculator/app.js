function calculator() {

    let [num1, num2, resultNum] = '';    
    const calculate = {
        add,
        subtract,
        init
    }

    return calculate;

    function add() {
        resultNum.value = Number(num1.value) + Number(num2.value);
    }

    function subtract() {
        resultNum.value = Number(num1.value) - Number(num2.value);
    }

    function init(number1, number2, resultNumber) {
        num1 = document.querySelector(number1);
        num2 = document.querySelector(number2);
        resultNum = document.querySelector(resultNumber);
    }

}




