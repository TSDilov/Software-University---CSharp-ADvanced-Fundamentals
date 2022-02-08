function sumFirstAndLast(input) {
    let firstNUmber = Number(input.shift());
    let secondNumber = Number(input.pop());
    return firstNUmber + secondNumber;
}
console.log(sumFirstAndLast(['20', '30', '40']));