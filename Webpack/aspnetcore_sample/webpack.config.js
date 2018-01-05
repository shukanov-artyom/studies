const ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = {
    entry: [
        './StaticAssets/Scripts/site.js'
    ],
    output: {
        filename: './wwwroot/js/bundle.js'
    },
    module: {
        loaders: [{
            test: /\.(jpg|png)$/,
            loader: 'file-loader',
            options: {
                outputPath: 'wwwroot/images/',
                useRelativePath: true
            }
        }, {
            test: /\.css$/,
            loaders: [
                'style-loader',
                'css-loader'
            ]
        }, {
            test: /\.less$/,
            exclude: /node_modules/,
            loader: ExtractTextPlugin.extract({
                fallback: 'style-loader',
                //resolve-url-loader may be chained before sass-loader if necessary
                use: ['css-loader', 'less-loader']
            })
        }, 
        { 
            test: /\.ts$/,
            loader: 'ts-loader' 
        }]
    },
    plugins: [
        new ExtractTextPlugin({
            filename: (getPath) => {
                return getPath('wwwroot/css/site.css');
            },
            allChunks: true
        })
    ]
}