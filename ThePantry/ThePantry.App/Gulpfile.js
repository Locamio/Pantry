var gulp = require('gulp'),
    autoprefixer = require('gulp-autoprefixer'),
    minifycss = require('gulp-minify-css'),
    jshint = require('gulp-jshint'),
    uglify = require('gulp-uglify'),
    concat = require('gulp-concat'),
    livereload = require('gulp-livereload'),
    del = require('del');

var config = {
    //Include all js files but exclude any min.js files
    src: ['App/**/*.js', '!App/**/*.min.js'],
}

// Synchronously delete the output file(s)
gulp.task('clean', function () {
    del.sync(['App/all.min.js'])
});

// Combine and minify all files from the app folder
gulp.task('scripts', ['clean'], function () {
    return gulp.src(config.src)
      .pipe(uglify())
      .pipe(concat('all.min.js'))
      .pipe(gulp.dest('App/'));
});

//Set a default tasks
gulp.task('default', ['scripts'], function () { });

var watch = require('gulp-watch');
gulp.task('watch', function () {
    return gulp.watch(config.src, ['scripts']);
});