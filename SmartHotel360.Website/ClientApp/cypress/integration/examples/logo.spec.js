describe('SmartHotel home page', function() {
  beforeEach(function() {
    cy.visit('https://smarthotel360demo.azurewebsites.net/');
  });
  
  it('contains "SmartHotel360" in the title', function() {
     cy.title().should('contain', 'SmartHotel360');
  });
});

describe('SmartHotel logo', function() {
  beforeEach(function() {
    cy.visit('https://smarthotel360demo.azurewebsites.net/');
  });
  
  it('has a visible smarthotel logo', function() {
     cy.get('.sh-nav_menu-logo is-home').should('be.visible');
   });
});

