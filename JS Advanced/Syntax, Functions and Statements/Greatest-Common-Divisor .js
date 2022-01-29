function greatestCommonDivisor(num1, num2){
    let minNum = Math.min(num1, num2);
    let divisor = 1;
    for ( i = 0; i <= minNum; i++){
        if (num1 % i === 0 && num2 % i === 0) {
            divisor = i;
        }
    }
    console.log(divisor);
}