function ticTacToe(moves) {
    let field = [[false, false, false],
                 [false, false, false],
                 [false, false, false]];
    let playerOnMove = 'X';
    let isVictory = false;

    for (let move of moves) {
        if (field.some(a => a.some(b => b === false))) {
            if(isVictory){
                break;
            }

            move = move.split(' ');
            let rowIndex = move[0];
            let columnIndex = move[1];
            if (!validateIndexes(rowIndex, columnIndex)) {
                continue;
            }

            if (field[rowIndex][columnIndex] !== false) {
                console.log('This place is already taken. Please choose another!');
                continue;
            }

            field[rowIndex][columnIndex] = playerOnMove;
            for (let i = 0; i < 3; i++) {
                if (checkFullRow(i, field) || checkFullColumn(i, field)) {
                    isVictory = true;
                }
            }

            if (checkFullFirstDiagonal(field) || checkFullSecondDiagonal(field)) {
                isVictory = true;
            }

            playerOnMove = nextPlayer(playerOnMove);
        }
    }

    if (!isVictory) {
        console.log('The game ended! Nobody wins :(');
    }else{
        playerOnMove = nextPlayer(playerOnMove);
        console.log(`Player ${playerOnMove} wins!`);
    }

    console.log(`${field[0][0]}\t${field[0][1]}\t${field[0][2]}`);
    console.log(`${field[1][0]}\t${field[1][1]}\t${field[1][2]}`);
    console.log(`${field[2][0]}\t${field[2][1]}\t${field[2][2]}`);

    function validateIndexes(row, col) {
        if (row >= 0 && row < 3 && col >= 0 && col < 3) {
            return true;
        }

        return false;
    }

    function checkFullRow(rowIndex, array) {
        if (array[rowIndex][0] === 'X' && array[rowIndex][1] === 'X' && array[rowIndex][2] === 'X') {
            return true
        }
        if (array[rowIndex][0] === 'O' && array[rowIndex][1] === 'O' && array[rowIndex][2] === 'O') {
            return true
        }

        return false;
    }

    function checkFullColumn(columnIndex, array) {
        if (array[0][columnIndex] === 'X' && array[1][columnIndex] === 'X' && array[2][columnIndex] === 'X') {
            return true
        }
        if (array[0][columnIndex] === 'O' && array[1][columnIndex] === 'O' && array[2][columnIndex] === 'O') {
            return true
        }

        return false;
    }

    function checkFullFirstDiagonal(array) {
        if (array[0][0] === 'X' && array[1][1] === 'X' && array[2][2] === 'X') {
            return true
        }
        if (array[0][0] === 'O' && array[1][1] === 'O' && array[2][2] === 'O') {
            return true
        }

        return false;
    }

    function checkFullSecondDiagonal(array) {
        if (array[0][2] === 'X' && array[1][1] === 'X' && array[2][0] === 'X') {
            return true
        }
        if (array[0][2] === 'O' && array[1][1] === 'O' && array[2][0] === 'O') {
            return true
        }

        return false;
    }

    function nextPlayer(player) {
        return player === 'X' ? 'O' : 'X';
    }
}
ticTacToe(["0 1",
"0 0",
"0 2",
"2 0",
"1 0",
"1 2",
"1 1",
"2 1",
"2 2",
"0 0"]

);