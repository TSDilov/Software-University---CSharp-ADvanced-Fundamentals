function biggestElementOfMatrix(matrix) {
    let biggestNumber = matrix[0][0];
    for (let row of matrix) {
        for (let number of row) {
            if (number > biggestNumber) {
                biggestNumber = number
            }
        }
    }
    return biggestNumber;
}
console.log(biggestElementOfMatrix([[20, 50, 10],[8, 33, 145]]));
