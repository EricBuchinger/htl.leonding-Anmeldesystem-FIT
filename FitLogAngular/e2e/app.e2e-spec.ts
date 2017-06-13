import { NewestFitAngularPage } from './app.po';

describe('newest-fit-angular App', () => {
  let page: NewestFitAngularPage;

  beforeEach(() => {
    page = new NewestFitAngularPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
