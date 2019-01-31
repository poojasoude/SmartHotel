describe('SmartHotel home page', function() {
  beforeEach(function() {
    cy.visit('https://smarthotel360demo.azurewebsites.net/');
  });
  
  it('contains "SmartHotel360" in the title', function() {
     cy.contains('Smart Room');
     cy.contains('Conference Room');
  });
});
