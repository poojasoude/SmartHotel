cy.get('.article').find('footer')

describe('SmartHotel footer ', function() {
  beforeEach(function() {
    cy.visit('https://smarthotel360demo.azurewebsites.net/');
  });
  
  it('contains footer', function() {
   cy.get('.sh-footer').find('Terms & Conditions')
  });
});