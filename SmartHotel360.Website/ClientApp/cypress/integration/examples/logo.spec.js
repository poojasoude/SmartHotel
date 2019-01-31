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
  
  it('Find the first li descendent within a ul', function() {
     cy.get('ul li:first').should('have.class', 'is-active')
   });
});

