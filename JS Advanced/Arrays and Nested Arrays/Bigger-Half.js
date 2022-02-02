function biggestHalf(input) {
    input.sort((a, b) => a - b);
    let biggestHalfSize;
    if (input.length % 2 != 0) {
        biggestHalfSize = Math.ceil(input.length / 2)        
    }else{
        biggestHalfSize = input.length / 2;
    }
    let biggestHalfArray = input.slice(input.length - biggestHalfSize);
    return biggestHalfArray;
}
console.log(biggestHalf([3, 19, 14, 7, 2, 19, 6]));