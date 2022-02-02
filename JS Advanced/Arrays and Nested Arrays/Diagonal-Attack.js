function diagonalAttack(array) {
    let matrixWithNumbers = [];
    for (let i = 0; i < array.length; i++) {
        let stringArrayOfNumbers = array[i].split(' ');
        let numberArray = [];
        for (let j = 0; j < stringArrayOfNumbers.length; j ++) {
            let number = Number(stringArrayOfNumbers[j]);
            numberArray.push(number);
        }

        matrixWithNumbers.push(numberArray);
    }

    let leftDiagonal = 0;
    let rightDiagonal = 0;
    for (let i = 0; i < matrixWithNumbers.length; i++) {
        leftDiagonal += matrixWithNumbers[i][i];
        rightDiagonal += matrixWithNumbers[i][matrixWithNumbers.length - 1 - i]
    }

    if (leftDiagonal === rightDiagonal) {
        for (let i = 0; i < matrixWithNumbers.length; i++) {
            for (let j = 0; j < matrixWithNumbers[i].length; j++) {
                if (i === j || (i + j) === matrixWithNumbers.length - 1) {
                    continue;
                }
                matrixWithNumbers[i][j] = leftDiagonal
            }
        }
    }

    for (let arrayWithNumbers of matrixWithNumbers) {
        console.log(arrayWithNumbers.join(' '));
    }
}
diagonalAttack(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']
);
