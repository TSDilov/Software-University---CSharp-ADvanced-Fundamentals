function SumOfColumnsAndRowsAreEqual(matrix) {
    let isEqual = true;
    let targetSum = 0;
    let sumOfRow = 0;
    let sumOfColumns = [];
    for (let i = 0; i < matrix[0].length; i++) {
        targetSum += matrix[0][i];
    }
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            sumOfRow += matrix[i][j];
            sumOfColumns[j] = (sumOfColumns[j] || 0) + matrix[i][j];
        }

        if (sumOfRow !== targetSum) {
            isEqual = false;
            return isEqual;
        }

        sumOfRow = 0;
    }

    if (sumOfColumns.some(num => num !== targetSum)) {
        isEqual = false;
        return isEqual;
    }
    return isEqual;
}
console.log(SumOfColumnsAndRowsAreEqual([[11, 32, 45],
[21, 0, 1],
[21, 1, 1]]
));