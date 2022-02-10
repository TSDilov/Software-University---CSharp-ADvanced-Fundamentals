function fromJSONTOHTMLTable(array) {
    let parcedJSON = JSON.parse(array);
    let finalArray = ['<table> '];
    finalArray.push(makeHeaders(parcedJSON));
    parcedJSON.forEach(record => finalArray.push(makeRecords(record)));
    finalArray.push('</table>');
    console.log(finalArray.join('\n'));

    function makeHeaders(array) {
        let result = '   <tr>';
        Object.keys(array[0]).forEach(key => {
            result += `<th>${escapeFunc(key)}</th>`;
        });
        result += '</tr>';
        return result;
    }

    function makeRecords(record) {
        let result = '   <tr>';
        Object.values(record).forEach(value => {
            result += `<td>${escapeFunc(value)}</td>`;
        });
        result += '</tr>';
        return result;
    }

    function escapeFunc(value) {
        return value
            .toString()
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}
fromJSONTOHTMLTable(`[{"Name":"Stamat",
"Score":5.5},
{"Name":"Rumen",
"Score":6}]`);