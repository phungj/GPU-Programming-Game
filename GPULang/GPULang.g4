grammar GPULang;

program: statement* EOF;
statement: assignment;
assignment: ID subscript '=' ID subscript;
subscript: '[' NUMBER ']';

ID: [a-zA-Z_][a-zA-Z_0-9]*;
NUMBER: [0-9]+;
WHITESPACE: [ \r\n\t]+ -> skip;