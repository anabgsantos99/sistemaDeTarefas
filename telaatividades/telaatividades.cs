﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using cadastrodeatividades;
using System.Runtime.InteropServices;




namespace telaatividades
{
    public partial class frmTeladeAtividade : Form
    {
        public string codigo;
        

        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=sistemasdetarefas";


        public frmTeladeAtividade()
        {
            InitializeComponent();

            //Configuração inicial de ListView para exibição dos dados dos clientes
            lstAtividades.View = View.Details;       //Define a visualização como "Detalhes"
            lstAtividades.LabelEdit = true;          //Permite editar os títulos das colunas
            lstAtividades.AllowColumnReorder = true; //Permite reordenar as colunas
            lstAtividades.FullRowSelect = true;      //Seleciona a linha inteira ao clicar
            lstAtividades.GridLines = true;          //Exibe as linhas de grade no ListView


            //Definindo as colunas do ListView
            lstAtividades.Columns.Add("Código", 100, HorizontalAlignment.Center); //Coluna codigo
            lstAtividades.Columns.Add("Ano", 100, HorizontalAlignment.Center); //Coluna ano
            lstAtividades.Columns.Add("Atividade", 700, HorizontalAlignment.Center); //Coluna atividade
            lstAtividades.Columns.Add("Semana", 100, HorizontalAlignment.Center); //Coluna semana
            lstAtividades.Columns.Add("Mês", 100, HorizontalAlignment.Center); //Coluna mes
            lstAtividades.Columns.Add("Status", 200, HorizontalAlignment.Center); //Coluna situacao
            lstAtividades.Columns.Add("Funcionária", 200, HorizontalAlignment.Center); //Coluna nomefuncionaria

            //Carrega os dados dos clientes na interface
            carregar_atividades();

        }


        protected void carregar_atividade_com_query(string query)
        {
            try
            {
                //cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa 
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens exixtentes no ListView antes de adicionar novos
                lstAtividades.Items.Clear();

                //Preenche o ListView com os dados dos clientes
                while (reader.Read())
                {
                    //Cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        Convert.ToString(reader.GetInt32(3)),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6)
                    };


                    //Adiciona a linha ao ListView
                    lstAtividades.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            finally
            {
                //Garante que a conexão com o banco de dados será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();

                    //Teste de fechamento de banco
                    //MessageBox.Show("Conexão fechada com sucesso");
                }
            }
        }

        private void carregar_atividades()
        {
            string query = "SELECT * FROM tarefa ORDER BY id DESC";
            carregar_atividade_com_query(query);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tarefa WHERE ano LIKE @q OR atividade LIKE @q OR semana LIKE @q OR mes LIKE @q OR situacao LIKE @q OR nomefuncionaria LIKE @q ORDER BY id DESC";
            carregar_atividade_com_query(query);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {


                if (lstAtividades.SelectedItems.Count > 0) // Verifica se há uma linha selecionada
                {

                    // Obtendo os dados da atividade selecionada
                    string codigo = lstAtividades.SelectedItems[0].SubItems[0].Text;
                    string ano = lstAtividades.SelectedItems[0].SubItems[1].Text;
                    string atividade = lstAtividades.SelectedItems[0].SubItems[2].Text;
                    string semana = lstAtividades.SelectedItems[0].SubItems[3].Text;
                    string mes = lstAtividades.SelectedItems[0].SubItems[4].Text;
                    string funcionaria = lstAtividades.SelectedItems[0].SubItems[6].Text;


                    //Exibir uma MessageBox com o código do cliente
                    MessageBox.Show("Código da tarefa: " + codigo,
                                     "Código Selecionado",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                    // Cria uma instância do formulário de atividades

                    cadastrodeatividades.frmCadastrodeAtividades outroFormulario = new cadastrodeatividades.frmCadastrodeAtividades(codigo, ano, atividade, semana, mes, funcionaria);


                    // Exibe o formulário criado
                    outroFormulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Selecione a atividade que deseja fazer a edição: ",
                        "Edição",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso não consiga abrir o formulário
                MessageBox.Show("Ocorreu um erro ao abrir o formulário: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnAlterarStatus_Click_1(object sender, EventArgs e)
        {
            try

            {
                if (lstAtividades.SelectedItems.Count > 0) // Verifica se há uma linha selecionada
                {

                    // Obtendo os dados da atividade selecionada
                    string codigo = lstAtividades.SelectedItems[0].SubItems[0].Text;
                    string status = lstAtividades.SelectedItems[0].SubItems[5].Text;
                    string situacao = "Finalizado";

                    // cria a conexão com o banco de dados

                    Conexao = new MySqlConnection(data_source);

                    Conexao.Open();

                    // Comando SQL para inserir um novo cliente no banco de dados

                    MySqlCommand cmd = new MySqlCommand
                    {

                        Connection = Conexao

                    };

                    cmd.Prepare();

                    //Update 

                    cmd.CommandText = $"UPDATE `tarefa` SET " +

                        $"situacao = @situacao " +

                        $"WHERE id = @codigo";

                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    cmd.Parameters.AddWithValue("@situacao", situacao);

                    // Set na situacao = finalizado

                    // where codigo =
                    cmd.ExecuteNonQuery();

                    //Mensagem de sucesso

                    MessageBox.Show($"O status com o código {codigo} foi alterado com Sucesso!",

                        "Sucesso",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Information);

                    carregar_atividades();

                }
            }

            catch (MySqlException ex)

            {

                //Trata erros relacionados ao MySQL

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,

                    "Erro",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                //Trata outros tipos de erro

                MessageBox.Show("Ocorreu: " + ex.Message,

                    "Erro",

                    MessageBoxButtons.OK,

                    MessageBoxIcon.Error);

            }

            finally

            {

                //Garante que a conexão com o banco de dados será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)

                {

                    Conexao.Close();

                    //Teste de fechamento de banco

                    //MessageBox.Show("Conexão fechada com sucesso");

                }

            }

        }
    }
}
