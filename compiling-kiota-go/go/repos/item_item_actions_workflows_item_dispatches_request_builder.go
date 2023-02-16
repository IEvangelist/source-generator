package repos

import (
    "context"
    i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f "github.com/microsoft/kiota-abstractions-go"
)

// ItemItemActionsWorkflowsItemDispatchesRequestBuilder builds and executes requests for operations under \repos\{owner}\{repo}\actions\workflows\{workflow_id}\dispatches
type ItemItemActionsWorkflowsItemDispatchesRequestBuilder struct {
    // Path parameters for the request
    pathParameters map[string]string
    // The request adapter to use to execute the requests.
    requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter
    // Url template to use to build the URL for the current request builder
    urlTemplate string
}
// ItemItemActionsWorkflowsItemDispatchesRequestBuilderPostRequestConfiguration configuration for the request such as headers, query parameters, and middleware options.
type ItemItemActionsWorkflowsItemDispatchesRequestBuilderPostRequestConfiguration struct {
    // Request headers
    Headers *i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestHeaders
    // Request options
    Options []i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestOption
}
// NewItemItemActionsWorkflowsItemDispatchesRequestBuilderInternal instantiates a new DispatchesRequestBuilder and sets the default values.
func NewItemItemActionsWorkflowsItemDispatchesRequestBuilderInternal(pathParameters map[string]string, requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter)(*ItemItemActionsWorkflowsItemDispatchesRequestBuilder) {
    m := &ItemItemActionsWorkflowsItemDispatchesRequestBuilder{
    }
    m.urlTemplate = "{+baseurl}/repos/{owner}/{repo}/actions/workflows/{workflow_id}/dispatches";
    urlTplParams := make(map[string]string)
    for idx, item := range pathParameters {
        urlTplParams[idx] = item
    }
    m.pathParameters = urlTplParams
    m.requestAdapter = requestAdapter
    return m
}
// NewItemItemActionsWorkflowsItemDispatchesRequestBuilder instantiates a new DispatchesRequestBuilder and sets the default values.
func NewItemItemActionsWorkflowsItemDispatchesRequestBuilder(rawUrl string, requestAdapter i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestAdapter)(*ItemItemActionsWorkflowsItemDispatchesRequestBuilder) {
    urlParams := make(map[string]string)
    urlParams["request-raw-url"] = rawUrl
    return NewItemItemActionsWorkflowsItemDispatchesRequestBuilderInternal(urlParams, requestAdapter)
}
// Post you can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see "[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch)."You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint. For more information, see "[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line)."
// [API method documentation]
// 
// [API method documentation]: https://docs.github.com/rest/reference/actions#create-a-workflow-dispatch-event
func (m *ItemItemActionsWorkflowsItemDispatchesRequestBuilder) Post(ctx context.Context, body ItemItemActionsWorkflowsItemDispatchesPostRequestBodyable, requestConfiguration *ItemItemActionsWorkflowsItemDispatchesRequestBuilderPostRequestConfiguration)(error) {
    requestInfo, err := m.ToPostRequestInformation(ctx, body, requestConfiguration);
    if err != nil {
        return err
    }
    err = m.requestAdapter.SendNoContent(ctx, requestInfo, nil)
    if err != nil {
        return err
    }
    return nil
}
// ToPostRequestInformation you can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see "[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch)."You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint. For more information, see "[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line)."
func (m *ItemItemActionsWorkflowsItemDispatchesRequestBuilder) ToPostRequestInformation(ctx context.Context, body ItemItemActionsWorkflowsItemDispatchesPostRequestBodyable, requestConfiguration *ItemItemActionsWorkflowsItemDispatchesRequestBuilderPostRequestConfiguration)(*i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.RequestInformation, error) {
    requestInfo := i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.NewRequestInformation()
    requestInfo.UrlTemplate = m.urlTemplate
    requestInfo.PathParameters = m.pathParameters
    requestInfo.Method = i2ae4187f7daee263371cb1c977df639813ab50ffa529013b7437480d1ec0158f.POST
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
