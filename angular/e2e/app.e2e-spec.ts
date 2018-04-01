import { ASPNetCoreAngularApp2TemplatePage } from './app.po';

describe('ASPNetCoreAngularApp2 App', function() {
  let page: ASPNetCoreAngularApp2TemplatePage;

  beforeEach(() => {
    page = new ASPNetCoreAngularApp2TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
