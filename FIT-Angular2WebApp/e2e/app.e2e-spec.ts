import { FITAngular2WebAppPage } from './app.po';

describe('fit-angular2-web-app App', function() {
  let page: FITAngular2WebAppPage;

  beforeEach(() => {
    page = new FITAngular2WebAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
