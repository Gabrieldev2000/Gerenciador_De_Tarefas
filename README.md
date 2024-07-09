<h1>Gerenciador de Tarefas</h1>
<p>Este projeto é um Gerenciador de Tarefas desenvolvido com <strong>C#</strong> para o backend utilizando <strong>ASP.NET Core MVC</strong> e <strong>SQLite in-memory</strong> para o banco de dados. O frontend é construído com <strong>React</strong>, proporcionando uma interface moderna e responsiva.</p>

<h2>Funcionalidades</h2>
<ul>
    <li><strong>Adicionar Tarefas:</strong> Crie novas tarefas com título, descrição, data de vencimento e status de conclusão.</li>
    <li><strong>Editar Tarefas:</strong> Edite tarefas existentes diretamente em uma janela modal flutuante.</li>
    <li><strong>Excluir Tarefas:</strong> Remova tarefas que não são mais necessárias.</li>
    <li><strong>Autenticação Segura:</strong> Login e registro de usuários utilizando <strong>JSON Web Tokens (JWT)</strong> para garantir a segurança dos dados.</li>
</ul>

<h2>Tecnologias Utilizadas</h2>
<h3>Backend</h3>
<ul>
    <li><strong>ASP.NET Core MVC:</strong> Framework para desenvolvimento web em C#.</li>
    <li><strong>Entity Framework Core:</strong> ORM para manipulação de dados.</li>
    <li><strong>SQLite in-memory:</strong> Banco de dados leve e rápido para testes e desenvolvimento.</li>
</ul>

<h3>Frontend</h3>
<ul>
    <li><strong>React:</strong> Biblioteca JavaScript para construção de interfaces de usuário.</li>
    <li><strong>Bootstrap:</strong> Framework CSS para design responsivo e moderno.</li>
    <li><strong>CSS Customizado:</strong> Estilização adicional para personalizar o tema escuro e imagens de fundo.</li>
</ul>

<h3>Autenticação</h3>
<ul>
    <li><strong>JWT (JSON Web Tokens):</strong> Método seguro para autenticação e autorização de usuários.</li>
</ul>

<h2>Estrutura do Projeto</h2>
<h3>Backend (C#)</h3>
<ul>
    <li><strong>Controllers:</strong> Controladores para gerenciar requisições HTTP e lógica de negócios.</li>
    <li><strong>Models:</strong> Modelos que representam os dados e entidades do sistema.</li>
    <li><strong>Services:</strong> Serviços para encapsular a lógica de negócios.</li>
    <li><strong>Repositories:</strong> Repositórios para interação com o banco de dados.</li>
</ul>

<h3>Frontend (React)</h3>
<ul>
    <li><strong>Componentes:</strong> Componentes React reutilizáveis para a interface de usuário.</li>
    <li><strong>Páginas:</strong> Páginas principais do aplicativo, como login, registro e lista de tarefas.</li>
    <li><strong>Estilos:</strong> Arquivos CSS para estilização do aplicativo.</li>
</ul>

<h2>Como Executar o Projeto</h2>
<h3>Pré-requisitos</h3>
<ul>
    <li><strong>.NET 8.0 SDK:</strong> Para o backend.</li>
    <li><strong>Node.js e npm:</strong> Para o frontend.</li>
</ul>

<h3>Passos</h3>
<ol>
    <li><strong>Clone o Repositório:</strong>
        <pre><code>git clone https://github.com/seu-usuario/gerenciador-de-tarefas.git
cd gerenciador-de-tarefas</code></pre>
    </li>
    <li><strong>Configuração do Backend:</strong>
        <pre><code>cd backend
dotnet restore
dotnet run</code></pre>
    </li>
    <li><strong>Configuração do Frontend:</strong>
        <pre><code>cd frontend
npm install
npm start</code></pre>
    </li>
    <li><strong>Acesse o Aplicativo:</strong>
        <p>Abra o navegador e vá para <a href="http://localhost:3000">http://localhost:3000</a></p>
    </li>
</ol>

<h2>Contribuição</h2>
<p>Sinta-se à vontade para contribuir com este projeto. Faça um fork do repositório, crie um branch para sua funcionalidade ou correção e envie um pull request. Toda contribuição é bem-vinda!</p>
