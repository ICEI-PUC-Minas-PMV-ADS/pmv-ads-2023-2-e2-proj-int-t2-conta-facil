# Registro de Testes de Software

## CT- Login – Realizar Login no site e realizar cadastro

1º - Acessando Tela Home
![Home](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/36486198/081df895-ff02-4eb0-81ce-4602b2cbc56f)

2º - Acessando Tela Login
![Tela Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/36486198/32e0e792-d578-4913-af73-cb8bf1868d24)

3º - Realizando Cadastro
![Cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/36486198/2bb4b716-690a-48ad-a9fb-fad8739ab999)

4º - Realizando Login
![Realizando Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/36486198/13582d25-3f3a-4121-b7f8-80837e881ed5)

5º - Login Realizado
![Login Realizado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/36486198/aea940bd-ea23-44a4-be17-ee9f86434c56)

6º - Painel de usuários cadastrados
![Painel de usuários cadastrados](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/36486198/0305204d-26ae-4263-8c97-31eb89ef72f8)

## Conclusão

O teste foi realizado com sucesso. Não encontramos nenhum erro ao realizar esse teste. 

## CT- Inserir dados financeiros – Reserva de Emergência

1º - Tela Principal Reserva de Emergência
![tela principal reserva de emergencia](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/71662852/a89c2a61-546e-45f5-b1d7-d0d2ca698928)

2º - Após clicar em "Calcular Reserva de Emergência", vai pra página para inserir os dados solicitados e cadastrar a reserva 
![calcular reserva 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/71662852/86ea0aa3-8344-4483-8b75-bffca6f688a3)

3º - Tela Principal exibindo a  Reserva que foi cadastrada
![historico reserva](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/71662852/94d29bd4-56db-4519-9e9d-d6f18f2b8692)

4º - Editando Reserva 
![editar reserva](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/71662852/58c4bae5-4782-4748-b573-eb142a212cc4)

5º - Apagando Reserva 
![apagar reserva](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-conta-facil/assets/71662852/cb47762d-99dd-465f-a5b3-a551160673af)

## Conclusão

- O botão de "Calcular Reserva de Emergência" redireciona para a página de cadastro da reserva com sucesso.
- Os botões de "Editar" e "Apagar" funcionam normalmente e consegue efetuar as duas ações.
- Ao clicar em "Salvar", o registro é enviado ao banco de dados e a página retorna para a tela principal exibindo o registro salvo.
  
Uma falha foi identificada ao realizar o teste:
- O botão calcular reserva não retorna o resultado do cálculo.
- É possível inserir os dados nos campos e salvar, porém o sistema apresenta falha ao calcular o valor da reserva. 


