function solution() {
    let result = '';
    return {
        append(text){
            result += text;
        },
        removeStart(num){
            result = result.slice(num);
        },
        removeEnd(num){
            result = result.slice(0, result.length - num);
        },
        print(){
            console.log(result);
        }
    }
}

let firstZeroTest = solution();

firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();

let secondZeroTest = solution();

secondZeroTest.append('123');
secondZeroTest.append('45');
secondZeroTest.removeStart(2);
secondZeroTest.removeEnd(1);
secondZeroTest.print();

