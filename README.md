# Cursos
Desafio Windows Forms e POO 
Neste desafio foi solicitado a organização dos arquivos de acordo com as regras abaixo .
Passos:
•	Crie a classe Pessoa
•	Crie a classe Aluno
•	Outras classes se necessário
•	Aluno herda os atributos e métodos de Pessoa
•	Analise o manual do arquivo .txt disponibilizado pelos professores para pensar nos métodos e atributos de cada classe
•	Leia o arquivo .txt disponibilizado pelos professores
•	Extraia os dados do .txt e crie objetos destes dados
•	Mostre na tela, quantos objetos Pessoa e quantos Alunos foram criados.
•	Mostre os cursos de cada Aluno!

Manual do arquivo txt:
Geral:
•	“-“ é o caractere delimitador, ele separa os dados em uma mesma linha!
•	Cada linha tem um significado
•	A linha que começa com “X” é o cabeçalho, só informa que o arquivo é referente Pessoas
•	A linha que começa com “Z” traz os dados dos alunos
•	A linha que começa com “Y”, é referente ao curso que a Pessoa esta cursando, a linha “Y” vem sempre depois de uma linha “Z”, 
logo, a linha “Y” é sobre o curso do Aluno(“Z”).
•	Nem sempre uma linha “Z” é seguida por uma linha “Y”, significa que é uma Pessoa cadastrada, e não um aluno. Logo, após
uma linha “Z” aparece outra linha “Z”.

Linha X:
•	Cabeçalho do arquivo
•	Exemplo : X-4565-486544
•	Dica: Ignorar esta linha

Linha Z:
•	Traz dados das pessoas
•	Sintaxe: Z-[nome]-[telefone]-[cidade]-[RG]-[CPF]

Linha Y:
•	Traz dados da matricula do aluno (curso)
•	Sintaxe: Y-[matricula]-[código do curso]-[nome do curso]
