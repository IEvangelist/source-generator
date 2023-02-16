package repos

import (
    "context"
    i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f "github.com/microsoft/kiota-abstractions-go"
    ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614 "github.com/octokit/kiota/models"
)

// ItemItemDeploymentsRequestBuilder builds and executes requests for operations under \repos\{owner}\{repo}\deployments
type ItemItemDeploymentsRequestBuilder struct {
    // Path parameters for the request
    pathParameters map[string]string
    // The request adapter to use to execute the requests.
    requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter
    // Url template to use to build the URL for the current request builder
    urlTemplate string
}
// ItemItemDeploymentsRequestBuilderGetQueryParameters simple filtering of deployments is available via query parameters:
type ItemItemDeploymentsRequestBuilderGetQueryParameters struct {
    // The name of the environment that was deployed to (e.g., `staging` or `production`).
    Environment *string
    // Page number of the results to fetch.
    Page *int32
    // The number of results per page (max 100).
    Per_page *int32
    // The name of the ref. This can be a branch, tag, or SHA.
    Ref *string
    // The SHA recorded at creation time.
    Sha *string
    // The name of the task for the deployment (e.g., `deploy` or `deploy:migrations`).
    Task *string
}
// ItemItemDeploymentsRequestBuilderGetRequestConfiguration configuration for the request such as headers, query parameters, and middleware options.
type ItemItemDeploymentsRequestBuilderGetRequestConfiguration struct {
    // Request headers
    Headers *i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestHeaders
    // Request options
    Options []i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestOption
    // Request query parameters
    QueryParameters *ItemItemDeploymentsRequestBuilderGetQueryParameters
}
// ItemItemDeploymentsRequestBuilderPostRequestConfiguration configuration for the request such as headers, query parameters, and middleware options.
type ItemItemDeploymentsRequestBuilderPostRequestConfiguration struct {
    // Request headers
    Headers *i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestHeaders
    // Request options
    Options []i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestOption
}
// NewItemItemDeploymentsRequestBuilderInternal instantiates a new DeploymentsRequestBuilder and sets the default values.
func NewItemItemDeploymentsRequestBuilderInternal(pathParameters map[string]string, requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter)(*ItemItemDeploymentsRequestBuilder) {
    m := &ItemItemDeploymentsRequestBuilder{
    }
    m.urlTemplate = "{+baseurl}/repos/{owner}/{repo}/deployments{?sha*,ref*,task*,environment*,per_page*,page*}";
    urlTplParams := make(map[string]string)
    for idx, item := range pathParameters {
        urlTplParams[idx] = item
    }
    m.pathParameters = urlTplParams
    m.requestAdapter = requestAdapter
    return m
}
// NewItemItemDeploymentsRequestBuilder instantiates a new DeploymentsRequestBuilder and sets the default values.
func NewItemItemDeploymentsRequestBuilder(rawUrl string, requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter)(*ItemItemDeploymentsRequestBuilder) {
    urlParams := make(map[string]string)
    urlParams["request-raw-url"] = rawUrl
    return NewItemItemDeploymentsRequestBuilderInternal(urlParams, requestAdapter)
}
// Get simple filtering of deployments is available via query parameters:
// [API method documentation]
// 
// [API method documentation]: https://docs.github.com/rest/deployments/deployments#list-deployments
func (m *ItemItemDeploymentsRequestBuilder) Get(ctx context.Context, requestConfiguration *ItemItemDeploymentsRequestBuilderGetRequestConfiguration)([]ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.Deploymentable, error) {
    requestInfo, err := m.ToGetRequestInformation(ctx, requestConfiguration);
    if err != nil {
        return nil, err
    }
    res, err := m.requestAdapter.SendCollection(ctx, requestInfo, ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.CreateDeploymentFromDiscriminatorValue, nil)
    if err != nil {
        return nil, err
    }
    val := make([]ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.Deploymentable, len(res))
    for i, v := range res {
        val[i] = v.(ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.Deploymentable)
    }
    return val, nil
}
// Post deployments offer a few configurable parameters with certain defaults.The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify thembefore we merge a pull request.The `environment` parameter allows deployments to be issued to different runtime environments. Teams often havemultiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parametermakes it easier to track which environments have requested deployments. The default environment is `production`.The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. Ifthe ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API willreturn a failure response.By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or tospecify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you donot require any contexts or create any commit statuses, the deployment will always succeed.The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON textfield that will be passed on when a deployment event is dispatched.The `task` parameter is used by the deployment system to allow different execution paths. In the web world this mightbe `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile anapplication with debugging enabled.Users with `repo` or `repo_deployment` scopes can create a deployment for a given ref.#### Merged branch responseYou will see this response when GitHub automatically merges the base branch into the topic branch instead of creatinga deployment. This auto-merge happens when:*   Auto-merge option is enabled in the repository*   Topic branch does not include the latest changes on the base branch, which is `master` in the response example*   There are no merge conflictsIf there are no new commits in the base branch, a new request to create a deployment should give a successfulresponse.#### Merge conflict responseThis error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can'tbe merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.#### Failed commit status checksThis error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.
// [API method documentation]
// 
// [API method documentation]: https://docs.github.com/rest/deployments/deployments#create-a-deployment
func (m *ItemItemDeploymentsRequestBuilder) Post(ctx context.Context, body ItemItemDeploymentsPostRequestBodyable, requestConfiguration *ItemItemDeploymentsRequestBuilderPostRequestConfiguration)(ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.Deploymentable, error) {
    requestInfo, err := m.ToPostRequestInformation(ctx, body, requestConfiguration);
    if err != nil {
        return nil, err
    }
    errorMapping := i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.ErrorMappings {
        "422": ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.CreateValidationErrorFromDiscriminatorValue,
    }
    res, err := m.requestAdapter.Send(ctx, requestInfo, ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.CreateDeploymentFromDiscriminatorValue, errorMapping)
    if err != nil {
        return nil, err
    }
    if res == nil {
        return nil, nil
    }
    return res.(ib19f1474616f80bb588b8a50bea93468536b3ba5d3dffa1c19a10387bd034614.Deploymentable), nil
}
// ToGetRequestInformation simple filtering of deployments is available via query parameters:
func (m *ItemItemDeploymentsRequestBuilder) ToGetRequestInformation(ctx context.Context, requestConfiguration *ItemItemDeploymentsRequestBuilderGetRequestConfiguration)(*i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestInformation, error) {
    requestInfo := i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.NewRequestInformation()
    requestInfo.UrlTemplate = m.urlTemplate
    requestInfo.PathParameters = m.pathParameters
    requestInfo.Method = i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.GET
    requestInfo.Headers.Add("Accept", "application/json")
    if requestConfiguration != nil {
        if requestConfiguration.QueryParameters != nil {
            requestInfo.AddQueryParameters(*(requestConfiguration.QueryParameters))
        }
        requestInfo.Headers.AddAll(requestConfiguration.Headers)
        requestInfo.AddRequestOptions(requestConfiguration.Options)
    }
    return requestInfo, nil
}
// ToPostRequestInformation deployments offer a few configurable parameters with certain defaults.The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify thembefore we merge a pull request.The `environment` parameter allows deployments to be issued to different runtime environments. Teams often havemultiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parametermakes it easier to track which environments have requested deployments. The default environment is `production`.The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. Ifthe ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds,the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API willreturn a failure response.By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success`state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or tospecify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you donot require any contexts or create any commit statuses, the deployment will always succeed.The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON textfield that will be passed on when a deployment event is dispatched.The `task` parameter is used by the deployment system to allow different execution paths. In the web world this mightbe `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile anapplication with debugging enabled.Users with `repo` or `repo_deployment` scopes can create a deployment for a given ref.#### Merged branch responseYou will see this response when GitHub automatically merges the base branch into the topic branch instead of creatinga deployment. This auto-merge happens when:*   Auto-merge option is enabled in the repository*   Topic branch does not include the latest changes on the base branch, which is `master` in the response example*   There are no merge conflictsIf there are no new commits in the base branch, a new request to create a deployment should give a successfulresponse.#### Merge conflict responseThis error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can'tbe merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.#### Failed commit status checksThis error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success`status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.
func (m *ItemItemDeploymentsRequestBuilder) ToPostRequestInformation(ctx context.Context, body ItemItemDeploymentsPostRequestBodyable, requestConfiguration *ItemItemDeploymentsRequestBuilderPostRequestConfiguration)(*i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestInformation, error) {
    requestInfo := i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.NewRequestInformation()
    requestInfo.UrlTemplate = m.urlTemplate
    requestInfo.PathParameters = m.pathParameters
    requestInfo.Method = i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.POST
    requestInfo.Headers.Add("Accept", "application/json")
    err := requestInfo.SetContentFromParsable(ctx, m.requestAdapter, "application/json", body)
    if err != nil {
        return nil, err
    }
    if requestConfiguration != nil {
        requestInfo.Headers.AddAll(requestConfiguration.Headers)
        requestInfo.AddRequestOptions(requestConfiguration.Options)
    }
    return requestInfo, nil
}
