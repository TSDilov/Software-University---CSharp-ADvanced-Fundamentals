function add(number) {
    let result = number;
    function sum(secondNumber) {
        result += secondNumber;
        return sum;
    }
    sum.toString = function () {
        return result;
    }

    return sum;
}
console.log(Number(add(1)(6)(-3)));