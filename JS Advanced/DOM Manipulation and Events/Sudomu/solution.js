function solve() {
    document.getElementsByTagName('button')[0].addEventListener('click', checkField);
    document.getElementsByTagName('button')[1].addEventListener('click', clearField);

    function checkField() {
        const sudokuMatrix = [];

        const firstRow = Array.from(document.getElementsByTagName('tr')[2].children).map(td => td = Number(td.children[0].value));
        const secondRow = Array.from(document.getElementsByTagName('tr')[3].children).map(td => td = Number(td.children[0].value));
        const thirdRow = Array.from(document.getElementsByTagName('tr')[4].children).map(td => td = Number(td.children[0].value));

        sudokuMatrix[0] = firstRow;
        sudokuMatrix[1] = secondRow;
        sudokuMatrix[2] = thirdRow;

        let rowsValid = checkRows(sudokuMatrix);
        let columnsValid = checkColumns(sudokuMatrix);

        if (rowsValid && columnsValid) {
            document.getElementsByTagName('table')[0].style.border = '2px solid green';
            document.querySelector('#check p').textContent = 'You solve it! Congratulations!';
            document.querySelector('#check p').style.color = 'green';
        }else{
            document.getElementsByTagName('table')[0].style.border = '2px solid red';
            document.querySelector('#check p').textContent = 'NOP! You are not done yet...';
            document.querySelector('#check p').style.color = 'red';
        }

        function checkRows(matrix){
            let isValid = false;
            for (let row of matrix) {
                if (row.some(x => x === 1) && row.some(x => x === 2) && row.some(x => x === 3)) {
                    isValid = true;
                }else{
                    isValid = false;
                    return isValid;
                }
            }

            return isValid;
        }

        function checkColumns(matrix) {
            let isValid = false;
            if ((matrix[0][0] === 1 || matrix[1][0] === 1 || matrix[2][0] === 1)
                && (matrix[0][0] === 2 || matrix[1][0] === 2 || matrix[2][0] === 2)
                && (matrix[0][0] === 3 || matrix[1][0] === 3 || matrix[2][0] === 3)) {

                isValid = true;
            }

            if ((matrix[0][1] === 1 || matrix[1][1] === 1 || matrix[2][1] === 1)
                && (matrix[0][1] === 2 || matrix[1][1] === 2 || matrix[2][1] === 2)
                && (matrix[0][1] === 3 || matrix[1][1] === 3 || matrix[2][1] === 3)
                && isValid) {

                isValid = true;
            }else{
                isValid = false;
            }

            if ((matrix[0][2] === 1 || matrix[1][2] === 1 || matrix[2][2] === 1)
                && (matrix[0][2] === 2 || matrix[1][2] === 2 || matrix[2][2] === 2)
                && (matrix[0][2] === 3 || matrix[1][2] === 3 || matrix[2][2] === 3)
                && isValid) {

                isValid = true;
            }else{
                isValid = false;
            }

            return isValid;
        }
    }

    function clearField() {
        Array.from(document.getElementsByTagName('input')).forEach(input => input.value = '');
        document.getElementsByTagName('table')[0].style.border = 'none';
        document.querySelector('#check p').textContent = '';
        document.querySelector('#check p').style.color = '';
    }
}