function aggregate(array) {
    let sum = 0;
    let inverseSum = 0;
    let concat = '';

    sum = array.reduce((tempSum, num) => tempSum + num, 0);
    inverseSum = array.reduce((tempSum, num) => tempSum + 1/num, 0);
    concat = array.join("");

    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}
aggregate([1,2,3]);