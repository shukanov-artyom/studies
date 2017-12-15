const fs = require('fs');
const download = require('download');
const jsdom = require('jsdom');
const { JSDOM } = jsdom;

var url = 'https://stackoverflow.com/questions/7372972/how-do-i-parse-a-html-page-with-node-js';
download(url).then(data => {
    const dom = new JSDOM(data.toString());
    const ps = dom.window.document.querySelectorAll('p');
    for (var key in ps) {
        console.log(key + ' : ' + ps[key]);
    }
});