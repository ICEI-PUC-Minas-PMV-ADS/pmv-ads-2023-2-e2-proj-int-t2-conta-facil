
# Plano de Testes de Software

Abaixo segue os casos de teste.

|**Caso de Teste**|**CT- Login – Realizar Login no site e realizar cadastro**|
| :-: | :- |
|**Requisitos Associados**|<p>**RF-01 -** O site deverá ter um sistema Login, para que o usuário acesse o painel do usuário.</p><p></p><p>**RF-02 -** O sistema deverá ter uma tela de cadastro de usuários.</p>|
|**Objetivo do Teste**|Verificar se após digitar o login e senha, o usuário será redirecionado para Home, verificar se o cadastro será criado com sucesso.|
|**Passos**|<p>1) Fazer o download da pasta contafacil2 e o arquivo ContaFacil2.sln [Git Hub.]([https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/blob/main/docs/08-Plano%20de%20Testes%20de%20Software.md](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/tree/main/src))</p><p>2) Abrir o Arquivo ContaFacil2.sln utilizando o visual Studio</p><p>3) Visualizar a página Home\.</p><p>4) Clicar em Login</p><p>5) Clique em Cadastro e depois realize o seu cadastro.</p><p>6) Após realizar o cadastro, você será redirecionado para tela de Login.</p><p>7) Digite o Email e senha e clique em Acessar.</p>|
|**Critérios de Êxito**|<p>- Você deverá ser redirecionado a pagina Home e irá aparecer as suas credenciais.</p><p>- Se for digitado um login e senha invalido o sistema não irá realizar login.</p><p>- Se for digitado um e-mail invalido, irá aparecer uma mensagem de e-mail invalido</p>|

 
|**Caso de Teste**|**CT -  Inserir dados financeiros**|
| :-: | :- |
|**Requisitos Associados**|<p>RF-03 - O sistema deverá ter a função de visualização de saldo atual. </p><p>RF-05 - O sistema deverá ter função de cadastro de despesas.</p><p>RF-04 - O sistema deverá ter um relatório de despesas.</p><p>RF-06 - O sistema deverá disponibilizar uma função de memória de cálculo para reserva emergencial.	</p>
|**Objetivo do Teste**|Verificar se as funcionalidades de inserção de dados financeiros, busca, filtro e edição estão funcionando conforme o esperado.|
|**Passos**|<p>1) Efetue o login no sistema. </p><p>2) Colocar o nome do produto ou gasto realizado no campo de busca ou Filtrar por: data de pagamento</p><p>3) No campo de inserção, preencha o nome do produto ou descrição do gasto realizado, bem como o valor financeiro correspondente.</p><p>4) Verifique se há um botão para cadastrar a despesa ou inserir os dados financeiros.</p><p>5) Após a inserção, verifique se os dados financeiros inseridos pelo usuário aparecem corretamente na interface. </p><p>6) Utilize o campo de busca para inserir o nome do produto ou descrição do gasto realizado. Verifique se os resultados são filtrados corretamente. <p/><p>7)Utilize a opção "Filtrar por data de pagamento" para verificar se o sistema filtra os dados com base na data de pagamento especificada. <p/><p>8)Caso o nome do produto, descrição ou data de pagamento não sejam localizados, verifique se uma mensagem informativa, como "Transação não localizada", é exibida. <p/><p>9)Se os dados forem localizados, verifique se a imagem e outras informações relevantes estão sendo exibidas corretamente. <p/><p>10)Clique na opção "Editar valor financeiro" e verifique se a descrição e o valor inseridos podem ser atualizados ou editados. <p/><p>11)Clique na opção "Reserva Emergencial" e utilize a função de memória de cálculo para calcular uma reserva emergencial com base nos dados financeiros inseridos.<p/>
|**Critérios de Êxito**|<p>- Os dados financeiros inseridos pelo usuário devem aparecer corretamente na interface após a inserção.</p><p>- Se não houver dados financeiros inseridos no sistema, uma mensagem informativa deve ser exibida, informando que nenhum dado foi encontrado. </p><p>- O filtro de busca deve mostrar o histórico de pagamentos e valores com base nas opções selecionadas, incluindo mês e ano. </p><p>- Os dados financeiros inseridos devem ter um botão de edição que permite a atualização das informações.</p><p>- Ao editar os dados, o sistema deve exibir uma confirmação de que os dados financeiros foram atualizados com sucesso.</p><p>-A função de memória de cálculo para reserva emergencial deve calcular corretamente com base nos dados financeiros inseridos.</p>


|**Caso de Teste**|**CT- Cadastro de Despesas – Realizar o cadastro de despesas e Visualização de saldo**|
| :-: | :- |
|**Requisitos Associados**|<p>**RF-03 -** O sistema deverá ter a função de visualização de saldo atual.</p><p></p><p>**RF-05 -** O sistema deverá ter função de cadastro de despesas.</p>|
|**Objetivo do Teste**|Verificar se o sistema está cadastrando despesas e mostrando o saldo corretamente.|
|**Passos**|<p>1) Efetue o login no sistema.</p><p>2) Clicar em cadastro.</p><p>3) Adicionar novo cadastro.</p><p>4) Preencher os campos Valor, Resumo e Tipo de Saldo.</p><p>5) Clicar em adicionar</p><p>6) Após realizar o cadastro de despesa, você será redirecionado para tela de seus cadastros.</p>|
|**Critérios de Êxito**|<p>- Você deverá ser redirecionado a pagina de Cadastro e irá aparecer suas despesas adicionadas.</p><p>- Se um campo ficar em branco o sistema não irá realizar o cadastro</p><p>- Se um campo ficar em branco o sistema deverá mostrar a mensagem de que deve ser obrigátorio o preenchimento.</p>|



|**Caso de Teste**|**CT- Relatório de Despesas – Exportar o relatório de despesas.**|
| :-: | :- |
|**Requisitos Associados**|<p>**RF-04-** O sistema deverá ter um relatório de despesas.</p><p></p>|
|**Objetivo do Teste**|Verificar se o sistema está realizando a exportação do relatorio de despesas corretamente.|
|**Passos**|<p>1) Efetue o login no sistema.</p><p>2) Clicar em cadastro.</p><p>3) Exportar.</p><p>4) Abrir o documento em excel na área de downloads.</p>|
|**Critérios de Êxito**|<p>- Quando clicar em exportar deverá ser baixado um documento em exel, com todas as despesas cadastradas.</p>|
