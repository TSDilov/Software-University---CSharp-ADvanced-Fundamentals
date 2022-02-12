function createSortedList() {
    let array = [];
    let objectWithFunctionsInColection = {
        add(element){
            array.push(element);
            array.sort((a, b) => a - b);
        },
        remove(index){
            if (index >= 0 && index < array.length) {
                array.splice(index, 1);
                array.sort((a, b) => a - b);
            }
        },
        get(index){
            if (index < 0 || index >= array.length) {
                throw new Error(`Index doesn't exist!`);
            }

            return array[index];
        },
        get size(){
            return array.length;
        },
    }

    return objectWithFunctionsInColection;
}
let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
console.log(list.size);

