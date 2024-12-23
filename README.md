### Descrição

Principal objetivo foi desenvolver uma API para um sistema Gerenciador de tarefas.
O sistema permiti que o usuário crie, visualize, edite e exclua uma tarefa.

---

### Requisitos

<aside>
Arquitetura em camadas

</aside>

Como visto em aula, é uma boa prática dividirmos a nossa aplicação em camadas. 
Por isso, o projeto contem: 

*Camada de comunicação*

*Camada de regras de negócios*

---

<aside>
Dados e campos

</aside>

Uma tarefa tem os seguintes campos:

- Um id único pra identificar cada tarefa;
- Um nome;
- Uma descrição sobre o que é a tarefa em si;
- Uma prioridade;
  *Prioridade* `alta`, `média` *ou* `baixa`*;*
- Uma data limite para tarefa ser realizada;
- Um status.
  *Três status:* `concluída`*,* `em andamento` *e* `aguardando`*.*

---

<aside>
Endpoints

</aside>

- É possível criar uma tarefa;
- Visualizar todas as tarefas criadas;
- Visualizar uma tarefa buscando pelo seu id;
- Editar informações de uma tarefa;
- Excluir uma tarefa.
