import "./Home.css"; // Import the custom CSS file

export const Home = () => {
  const githubSearchExampleUrl =
  "https://github.com/search?q=language:javascript+stars:>100+pushed:>2023-01-01";
const githubAdvancedSearchUrl = "https://github.com/search/advanced";
const searchTipsUrl = "https://docs.github.com/en/search-github/github-code-search/understanding-github-code-search-syntax";

  return (
    <div className="home-container">
      <h1 className="home-title">Welcome to NSS Final Project</h1>

      <p className="home-paragraph">For Some Info On Search Tips</p>
      <a
        href={searchTipsUrl}
        target="_blank"
        className="btn btn-primary d-block mb3"
        rel="noopener noreferrer"
      >
        Click Here For Search Tips
      </a>

      <p className="home-paragraph">Search for open source projects on GitHub to contribute to.</p>

      <div className="button-group">
      <a
        href={githubAdvancedSearchUrl}
        target="_blank"
        rel="noopener noreferrer"
        className="btn btn-secondary d-block mb-3"
      >
        Click Here to Do a Full Comprehensive Search of GitHub Repos
      </a>

      <a
        href={githubSearchExampleUrl}
        target="_blank"
        rel="noopener noreferrer"
        className="btn btn-primary d-block mb-3"
      >
        Click Here to See an Example Search and How You Can Add Fields to Search By as Your Parameters
      </a>

  </div>

      <div className="card mt-3">
        <div className="card-body">
          <h5 className="card-title">Common Features to Search By:</h5>
          <ul>
            <li>Language</li>
            <li>Stars</li>
            <li>Labels</li>
            <li>Last Updated</li>
            <li>Topics</li>
            <li>Issue/PR Filters</li>
          </ul>
        </div>
      </div>
    </div>
  );
};
