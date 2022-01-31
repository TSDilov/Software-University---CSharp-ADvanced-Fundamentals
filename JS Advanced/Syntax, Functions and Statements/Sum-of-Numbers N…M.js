function sumOfNumbersBetweenTwoNumbers(n, m){
    let num1 = Number(n);
    let num2 = Number(m);
    let sum = 0;
    for (let number = num1; number <= num2; number++){
        sum += number;
    }
    return sum;
}
console.log(sumOfNumbersBetweenTwoNumbers(`1`, `5`));