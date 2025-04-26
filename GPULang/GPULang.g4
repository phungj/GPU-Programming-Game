grammar GPULang;

program: statement* EOF;
statement: assignment;
assignment: ID subscript '=' ID subscript;
subscript: '[' INT ']';

ID: [a-zA-Z_][a-zA-Z_0-9]*;
INT: [1-9][0-9]*;
WHITESPACE: [ \r\n\t]+ -> skip;