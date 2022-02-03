function diagonalSums(matrix) {
    let firstDiagonal = 0;
    let secondDiogonal = 0;
    let firstIndex = 0;
    let secondIndex = matrix.length - 1;
    matrix.forEach(array => {
        firstDiagonal += array[firstIndex++];
        secondDiogonal += array[secondIndex--];
    });
    console.log(`${firstDiagonal} ${secondDiogonal}`);
}
diagonalSums([[20, 40],
[10, 60]]
);